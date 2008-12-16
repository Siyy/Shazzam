//--------------------------------------------------------------------------------------
// 
// WPF ShaderEffect HLSL -- Wavy
//
//--------------------------------------------------------------------------------------

//-----------------------------------------------------------------------------------------
// Shader constant register mappings (scalars - float, double, Point, Color, Point3D, etc.)
//-----------------------------------------------------------------------------------------

float waveDepth : register(c0); // try values from 0 to .1
float waveWidth : register(c1); // try values from 1 to 20000

//--------------------------------------------------------------------------------------
// Sampler Inputs (Brushes, including ImplicitInput)
//--------------------------------------------------------------------------------------

sampler2D  implicitInputSampler : register(S0);


float4 main(float2 uv : TEXCOORD) : COLOR
{
   //float4 Color;
    uv.y = uv.y + (sin(uv.x*waveWidth)*waveDepth);
    //Color = ;
    return tex2D( implicitInputSampler, uv.xy);

}

