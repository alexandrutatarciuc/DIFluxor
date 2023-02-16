using Fluxor;

namespace DIFluxor.Store;

[FeatureState]
public class CounterState
{
    public int Counter { get; }

    public CounterState()
    {
    }

    public CounterState(int counter)
    {
        Counter = counter;
    }
}