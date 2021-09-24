<style>
commit{
    color:orange;
}
heading{
    color:firebrick;
    font-weight: bold;
}
</style>
# <heading>Instructions</heading>

## <heading>Introduction</heading>

This kata is designed to help you learn how to refactor to the Strategy pattern (https://refactoring.guru/design-patterns/strategy)

There are two classes called Widget and Shape, which have complicated behaviour that is different depending on what their Type is. And their type can change at run-time. 
Your goal is to create classes for each strategy, and to move the logic into these classes.

There are existing tests which should be comprehensive enough to give you a safety harness as you refactor, but you might need to update them as you go.

You should be able to refactor in small incremental steps, and make sure that the tests are passing after each step.

## <heading>Step 1: Move the Describe logic into a Strategy</heading>

We want a new class called Strategy, which will handle the Describe logic. We will call it from the Widget's Describe method.

Create a new class called Strategy. Give it a Describe method. Move all the logic from Widget into it. The Strategy's Describe method will take in a Type, instead of having a member variable.

Create an instance of Strategy in Widget's Describe method, and forward the call on to the Strategy. 

<commit>Compile and run tests. Commit if they pass.</commit>

## <heading>Step 2: Move the Draw logic into a Strategy</heading>

Repeat Step 1 to move the Widget's Draw logic into Strategy.

<commit>Compile and run tests. Commit if they pass.</commit>

## <heading>Step 3: Update the Strategy's constructor to take in the Type.</heading>

Change the constructor of Strategy so that it takes in the Type. Remove it as a parameter from Draw and Describe on Strategy.

<commit>Compile and run tests. Commit if they pass.</commit>

## <heading>Step 4: Update Widget to take in a Strategy</heading>

Update Widget so that it takes in a reference to Strategy and stores it, instead of taking in a Type. 

It should forward on the calls to Draw and Describe to this Strategy. 

The tests will need to be updated to create the Strategy and pass it through to the Widget.
    
<commit>Compile and run tests. Commit if they pass.</commit>

## <heading>Step 5: Create specific strategies</heading>

Create subclasses of Strategy - one for each value of Type.

<commit>Compile and run tests. Commit if they pass.</commit>

Move the logic from Draw and Describe down into the derived classes. 

In the tests, create instances of the Derived classes instead of the Base class.

<commit>Compile and run tests. Commit if they pass.</commit>

## <heading>Step 6: Remove all references to the Type</heading>

The Strategy base class should now be abstract. It no longer needs to have a Type set or stored. Maybe turn it into an interface?

## <heading>Step 7: Apply the same solution to Shape</heading>

Shape uses the same Type enum. Update it to use a Strategy instead.

The Type enum class can now be removed.
