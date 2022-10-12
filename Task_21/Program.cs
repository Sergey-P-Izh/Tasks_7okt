// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

public struct SectorPos
{
    public readonly Int64 X;
    public readonly Int64 Y;
    public readonly Int64 Z;

    public SectorPos(Int64 x, Int64 y, Int64 z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
public struct LocalPos
{
    public readonly Int32 X;
    public readonly Int32 Y;
    public readonly Int32 Z;

    public LocalPos(Int32 x, Int32 y, Int32 z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

struct Pos
{
    public readonly SectorPos Sector;
    public readonly LocalPos Local;

    public Pos(SectorPos sector, LocalPos local)
    {
        Sector = sector;
        Local = local;
    }
}

void Test()
{
    // Should be 1:
    Double d1 = Distance(new Pos(new SectorPos(0, 0, 0), 
                                 new LocalPos(Int32.MaxValue, 0, 0)), 
                         new Pos(new SectorPos(0, 1, 0), 
                                 new LocalPos(Int32.MinValue, 0, 0)));
    // Should be -1: (EDIT: Should be 1 of course)
    Double d2 = Distance(new Pos(new SectorPos(0, -2, 0), 
                                 new LocalPos(Int32.MaxValue, 0, 0)), 
                         new Pos(new SectorPos(0, -3, 0), 
                                 new LocalPos(Int32.MinValue, 0, 0)));
    // Should be Int32.MaxValue+1:
    Double d3 = Distance(new Pos(new SectorPos(1, 0, 0), 
                                 new LocalPos(Int32.MaxValue, 0, 0)), 
                         new Pos(new SectorPos(3, 0, 0), 
                                 new LocalPos(Int32.MinValue, 0, 0))); 
}