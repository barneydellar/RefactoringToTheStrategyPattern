#pragma once
#include "ICanvas.h"

class MockCanvas : public ICanvas
{
public:
    MAKE_MOCK1(DrawVertex, void(Point), override);
};
