#include "pch.h"

#include "Shape.h"
#include "MockCanvas.h"
#include "Type.h"

TEST_CASE("A Shape can be created")
{
    Shape{ Type::Triangle };
}

TEST_CASE("A Shape can be drawn")
{
    const Shape s(Type::Triangle);
    MockCanvas c;
    ALLOW_CALL(c, DrawVertex(ANY(Point)));

    s.Draw(c);
}

TEST_CASE("A triangular shape draws correctly")
{
    const Shape s(Type::Triangle);
    MockCanvas c;

    REQUIRE_CALL(c, DrawVertex(Point{ 0, 0 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 2, 0 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 1, 2 })).TIMES(1);

    s.Draw(c);
}

TEST_CASE("A square shape draws correctly")
{
    const Shape s(Type::Square);
    MockCanvas c;

    REQUIRE_CALL(c, DrawVertex(Point{ 0, 0 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 2, 0 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 2, 2 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 0, 2 })).TIMES(1);

    s.Draw(c);
}

TEST_CASE("A pentagon shape draws correctly")
{
    const Shape s(Type::Pentagon);
    MockCanvas c;

    REQUIRE_CALL(c, DrawVertex(Point{ 0, 0 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 2, 0 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 2, 2 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 1, 3 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 0, 2 })).TIMES(1);

    s.Draw(c);
}

TEST_CASE("A hexagon shape draws correctly")
{
    const Shape s(Type::Hexagon);
    MockCanvas c;

    REQUIRE_CALL(c, DrawVertex(Point{ 0, 0 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 2, 0 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 3, 1 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 2, 2 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ 0, 2 })).TIMES(1);
    REQUIRE_CALL(c, DrawVertex(Point{ -1, 1 })).TIMES(1);

    s.Draw(c);
}