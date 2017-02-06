Shader "Custom/ZED RGB-Depth"
{
	Properties
	{
		[HideInInspector] _MainTex("Base (RGB) Trans (A)", 2D) = "" {}
	_DepthXYZTex("Depth texture", 2D) = "" {}
	_CameraTex("Texture from ZED", 2D) = "" {}
	
	}
	SubShader
	{
		// No culling or depth
		ZWrite On
		Tags{
		"Queue" = "Background"
		}

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"
			#include "S_ZED_Utils.cginc"
			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Input {
				float2 uv_MainTex;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
				
			};

			struct fragOut {

				float depth : SV_Depth;
				fixed4 color : SV_Target;
			};
			uniform float4x4 _ProjectionMatrix;
			sampler2D _DepthXYZTex;
			sampler2D _CameraTex;
			uniform float4 _MaskTex_ST;
			float4 _MainTex_ST;
			uniform int _isGrey;

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = mul(mul(mul(_ProjectionMatrix, UNITY_MATRIX_V), UNITY_MATRIX_M ), v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				return o;
			}


			fragOut frag(v2f i)
			{
				//Get the depth in XYZ format
				float3 colorXYZ = tex2D(_DepthXYZTex, (i.uv*fixed2(1, -1))).rgb;
				//Compute the depth to work with Unity (1m real = 1m to Unity)
				float depthReal = computeDepthXYZ(colorXYZ);

				//Color from the camera
				fragOut o;
				if (_isGrey == 0) {
					float3 colorCamera = tex2D(_CameraTex, i.uv*fixed2(1, -1)).bgr;
					o.color.rgb = colorCamera.rgb;
				}
				else {
					float colorCamera = tex2D(_CameraTex, i.uv*fixed2(1, -1)).a;
					o.color.rgb = colorCamera;
				}
				o.color.a = 1;

				o.depth = depthReal;


				return o;
			}
			ENDCG
		}
	}
}
