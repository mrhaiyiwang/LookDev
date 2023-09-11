Hello!

Thank you for taking the time to experience the Demo. The usage instructions are attached below. There is an introduction to the rendering process at the end of the article.

Camera browsing:
Hold down the left button and drag: offset; hold down the right button and drag: rotate; mouse wheel: zoom

PBR material editor:
(keyboard keys)
Hold down W: increase metallicity; hold down S: decrease metallicity; hold down W: increase roughness; hold down A: decrease roughness.

================================================== ==========================

Introduction to rendering process:

Used Unity engine to build demo

Camera browsing and frame rate: implement related scripts by yourself

Physically based lighting: implement PBR.shader by yourself, which can be viewed in Project/Asset

Shader ball and skybox: https://ambientcg.com/

Shader workflow overview:
Define attributes - vertex shader (normal mapping) - fragment shader (diffuse + specular; direct lighting and environment indirect lighting are calculated separately) - output

The BRDF implementation is located in the PBRLib.cginc file, using Lambertian diffuse shading, and the Fresnel term refers to disney brdf (2015). The normal distribution function and geometric shading function adopt the trowbridgeReitz model (1975) and schlick approximation (1994) respectively.
