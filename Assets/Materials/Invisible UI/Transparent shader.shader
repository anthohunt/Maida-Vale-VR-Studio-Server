Shader "Masked/Mask" {

	SubShader{
		Tags {"Queue" = "Geometry10"}

		ColorMask 0
		Zwrite On

		Pass {}
	}
}