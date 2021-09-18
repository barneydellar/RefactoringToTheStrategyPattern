#pragma once
#include "ICanvas.h"
#include "Type.h"

class Widget {
public:

    void SetType(Type);
    [[nodiscard]] std::string Describe() const;
    void Draw(ICanvas& canvas) const;

private:
    Type m_type = Type::Triangle;
};
