Shader "Unlit/See through shader"
{
    
    SubShader
    {
        Tags {"Queue" = "Transparent+1"} // convert this to a 3001 render queue because transparent is in 3000 queue

        Pass { Blend Zero One } //this shader blends whatever is behind
    }
}
