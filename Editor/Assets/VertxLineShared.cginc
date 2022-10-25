// #include "UnityCG.cginc"
#include "VertxDebuggingShared.cginc"

struct Line
{
    float3 A, B;
};

struct LineGroup
{
    Line A;
    float4 Color;
};

StructuredBuffer<LineGroup> line_buffer;

struct vertInput
{
    float2 uv : TEXCOORD0;
    uint vertexID : SV_VertexID;
    uint instanceID : SV_InstanceID;
};

struct v2f
{
    float4 position : SV_POSITION;
    float4 color : TEXCOORD1;
};

v2f vert(vertInput input)
{
    v2f o;
    int index = input.instanceID * 128 + input.vertexID / 2;
    if (index >= _InstanceCount)
    {
        o.position = 0;
        o.color = 0;
        return o;
    }
    
    LineGroup lg = line_buffer[index];
    Line l = lg.A;
    o.position = world_to_clip_pos(input.vertexID % 2 == 0 ? l.A : l.B);
    o.color = lg.Color;
    return o;
}
