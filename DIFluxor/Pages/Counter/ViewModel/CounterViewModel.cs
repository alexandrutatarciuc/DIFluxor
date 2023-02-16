using DIFluxor.Store;
using Fluxor;

namespace DIFluxor.Pages.Counter.ViewModel;

public class CounterViewModel : ICounterViewModel
{
    private readonly IState<CounterState> _state;

    public CounterViewModel(IState<CounterState> state)
    {
        _state = state;
    }

    public int GetCount()
    {
        return _state.Value.Counter;
    }

    public void PrintCounterToConsole()
    {
        Console.WriteLine($"ViewModel printed this counter value: {_state.Value.Counter}");
    }
}

public interface ICounterViewModel
{

    int GetCount();
    void PrintCounterToConsole();
}