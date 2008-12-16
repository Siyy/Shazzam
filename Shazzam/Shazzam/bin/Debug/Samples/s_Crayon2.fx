//--------------------------------------------------------------------------------------
// 
// WPF ShaderEffect HLSL -- Crayon
// Created by Walt Ritscher
// wpfwonderland.wordpress.com
//
//--------------------------------------------------------------------------------------


sampler2D  implicitInputSampler : register(S0);

//--------------------------------------------------------------------------------------
// Pixel Shader
//--------------------------------------------------------------------------------------

float4 main(float2 uv : TEXCOORD) : COLOR
{
   float4 color = tex2D( implicitInputSampler, uv );
   
   // change red channel
   if(color.r <0.6)
   {
   	 color.r= color.r*2;
   }
   if(color.r>0.8){
   	color.g = color.r *2;
   }

  
   if(color.b <0.6)
   {
   	 color.b= color.b*2;
   }
   if(color.b <0.8)
   {
   	 color.r= color.b/2;
   }
    if(color.g > 0.8)
   {
   	 color.b= color.g/2;
   }
    
  
   
   return color;
}
