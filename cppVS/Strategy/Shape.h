#pragma once
#include "ICanvas.h"
#include "Type.h"

class Shape
{
public:
    void Draw(ICanvas& canvas) const;
    explicit Shape(Type t);
private:
    Type m_type;
};

