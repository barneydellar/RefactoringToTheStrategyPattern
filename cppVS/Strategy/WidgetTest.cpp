#include "pch.h"

#include "MockCanvas.h"
#include "Type.h"
#include "Widget.h"

TEST_CASE("A Widget can be created")
{
    Widget{};
}

TEST_CASE("A Widget can describe itself")
{
    const Widget w{};
    const std::string description = w.Describe();
}

TEST_CASE("A Widget starts as a triangle")
{
    const Widget w{};
    CHECK(w.Describe() == "Triangle");
}

TEST_CASE("A Widget's type can be changed at run-time")
{
    Widget w{};
    REQUIRE(w.Describe() == "Triangle");
    w.SetType(Type::Square);

    CHECK(w.Describe() == "Square");
}

TEST_CASE("A Widget can set to be a triangle")
{
    Widget w{};
    w.SetType(Type::Triangle);
}

TEST_CASE("A triangular widget describes itself as a triangle")
{
    Widget w{};
    w.SetType(Type::Triangle);

    CHECK(w.Describe() == "Triangle");
}

TEST_CASE("A triangular widget draws as a triangle")
{
    Widget w{};
    w.SetType(Type::Triangle);

    MockCanvas c;
    REQUIRE_CALL(c, DrawVertex(ANY(Point))).TIMES(3);

    w.Draw(c);
}

TEST_CASE("A Widget can set to be a square")
{
    Widget w{};
    w.SetType(Type::Square);
}

TEST_CASE("A square widget describes itself as a square")
{
    Widget w{};
    w.SetType(Type::Square);

    CHECK(w.Describe() == "Square");
}

TEST_CASE("A square widget draws as a square")
{
    Widget w{};
    w.SetType(Type::Square);

    MockCanvas c;
    REQUIRE_CALL(c, DrawVertex(ANY(Point))).TIMES(4);

    w.Draw(c);
}

TEST_CASE("A Widget can set to be a pentagon")
{
    Widget w{};
    w.SetType(Type::Pentagon);
}

TEST_CASE("A pentagon widget describes itself as a pentagon")
{
    Widget w{};
    w.SetType(Type::Pentagon);

    CHECK(w.Describe() == "Pentagon");
}

TEST_CASE("A pentagon widget draws as a pentagon")
{
    Widget w{};
    w.SetType(Type::Pentagon);

    MockCanvas c;
    REQUIRE_CALL(c, DrawVertex(ANY(Point))).TIMES(5);

    w.Draw(c);
}

TEST_CASE("A Widget can set to be a hexagon")
{
    Widget w{};
    w.SetType(Type::Hexagon);
}

TEST_CASE("A hexagon widget describes itself as a hexagon")
{
    Widget w{};
    w.SetType(Type::Hexagon);

    CHECK(w.Describe() == "Hexagon");
}

TEST_CASE("A hexagon widget draws as a hexagon")
{
    Widget w{};
    w.SetType(Type::Hexagon);

    MockCanvas c;
    REQUIRE_CALL(c, DrawVertex(ANY(Point))).TIMES(6);

    w.Draw(c);
}