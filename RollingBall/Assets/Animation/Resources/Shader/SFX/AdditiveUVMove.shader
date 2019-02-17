// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/SFX/AdditiveUVMove" 
{
	Properties 
	{
		_TintColor ("Tint Color", Color) = (0.5,0.5,0.5,0.5)
		_MainTex ("Particle Texture", 2D) = "white" {}
		_UVLength("UVLength",Float) = 8
		_UVTime("UVTime",Float) = 0.1
	}
	SubShader
	{
		Tags{ "Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent" }
		Blend SrcAlpha One
		ColorMask RGB
		Cull Off ZWrite Off Fog{ Mode Off }
		Pass
		{

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"
			struct appdata_t 
			{
				float4 vertex : POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f 
			{
				half4 vertex : SV_POSITION;
				fixed4 color : COLOR;
				half2 texcoord : TEXCOORD0;
			};

			sampler2D _MainTex;
			fixed4 _TintColor;
			half4 _MainTex_ST;
			fixed _UVLength;
			fixed _UVTime;

			v2f vert(appdata_t v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.color = v.color;
				o.texcoord = TRANSFORM_TEX(v.texcoord,_MainTex);
				half timeInOneCycle = fmod(_Time.y,_UVLength*_UVTime);
				timeInOneCycle = floor(timeInOneCycle/_UVTime);
				o.texcoord.x += timeInOneCycle*(1/_UVLength);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target
			{
				return 2.0f * i.color*_TintColor * tex2D(_MainTex, i.texcoord);
			}
			ENDCG
		}
	}
}
