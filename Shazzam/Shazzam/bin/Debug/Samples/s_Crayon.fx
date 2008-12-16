//--------------------------------------------------------------------------------------
// 
// WPF ShaderEffect HLSL -- Crayon
// Created by Walt Ritscher
// wpfwonderland.wordpress.com
//
//--------------------------------------------------------------------------------------

//--------------------------------------------------------------------------------------
// Sampler Inputs (Brushes, including ImplicitInput)
//--------------------------------------------------------------------------------------

sampler2D  implicitInputSampler : register(S0);

//--------------------------------------------------------------------------------------
// Pixel Shader
//--------------------------------------------------------------------------------------

float4 main(float2 uv : TEXCOORD) : COLOR
{
   float4 color = tex2D( implicitInputSampler, uv );
   if(color.r <0.6)
   {
   	 color.r= color.r*2;
   }
   if(color.g <0.6)
   {
   	 color.g= color.g*3;
   }
   if(color.b <0.6)
   {
   	 color.b= color.b*2;
   }
  
   
   return color;
}
