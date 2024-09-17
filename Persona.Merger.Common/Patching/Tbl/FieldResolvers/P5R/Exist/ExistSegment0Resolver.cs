using Sewer56.StructuredDiff.Interfaces;

namespace Persona.Merger.Patching.Tbl.FieldResolvers.P5R.Exist;

public struct ExistSegment0Resolver : IEncoderFieldResolver
{
    public bool Resolve(nuint offset, out int moveBy, out int length)
    {
        // Unknown data
        moveBy = 0;
        length = 1;
        return false;
    }
}