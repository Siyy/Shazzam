//--------------------------------------------------------------------------------------
// 
// WPF ShaderEffect HLSL -- ColorSwap
// Created by Walt Ritscher
// wpfwonderland.wordpress.com
//
//--------------------------------------------------------------------------------------


sampler2D  implicitInputSampler : register(S0);
float threshold : register(c0);
float redMultiplier : register(c1);
float greenMultiplier : register(c2);
float blueMultiplier : register(c3);

//--------------------------------------------------------------------------------------
// Pixel Shader
//--------------------------------------------------------------------------------------

float4 main(float2 uv : TEXCOORD) : COLOR
{
   float4 color = tex2D( implicitInputSampler, uv );
   
   // change red channel
   if(color.r <threshold)
   {
   	 color.r= color.g*redMultiplier;
   }
   if(color.g <threshold)
   {
   	 color.g= color.b*greenMultiplier;
   }
   if(color.b <threshold)
   {
   	 color.b= color.r*blueMultiplier;
   }
  
  
  
    
  
   
   return color;
}
