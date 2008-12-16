//--------------------------------------------------------------------------------------
// 
// WPF ShaderEffect HLSL -- Crayon
// Created by Walt Ritscher
// wpfwonderland.wordpress.com
//
//--------------------------------------------------------------------------------------


sampler2D  implicitInputSampler : register(S0);
float threshold : register(c0);

//--------------------------------------------------------------------------------------
// Pixel Shader
//--------------------------------------------------------------------------------------

float4 main(float2 uv : TEXCOORD) : COLOR
{
   float4 color = tex2D( implicitInputSampler, uv );
   
   // change red channel
   if(color.r <threshold)
   {
   	 color.r= color.g*2;
   }
   if(color.g <threshold)
   {
   	 color.g= color.b*2;
   }
   if(color.b <threshold)
   {
   	 color.b= color.r*2;
   }
  
  
  
    
  
   
   return color;
}
