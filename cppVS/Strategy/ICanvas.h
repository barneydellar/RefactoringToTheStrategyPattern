#pragma once
#include "Point.h"

class ICanvas
{
public:
    virtual void DrawVertex(Point) = 0;
};

