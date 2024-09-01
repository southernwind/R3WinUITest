using Reactive.Bindings;

using System.Threading.Tasks;

namespace R3WinUITest;

public class ReactivePropertyViewModel {

    public ReactiveProperty<int> Count { get; } = new();

    public ReactiveCommand IncrementCommand { get; } = new();

    public ReactiveCommand IncrementInTaskCommand { get; } = new();

    public ReactiveCollection<string> Collection { get; } = ["Item 0", "Item 1"];

    public ReactiveCommand AddCommand { get; } = new();
    public ReactivePropertyViewModel()
    {
        this.IncrementCommand.Subscribe(() => this.Count.Value++);
        this.IncrementInTaskCommand.Subscribe(() => {
            Task.Run(() =>
            {
                this.Count.Value++;
            });
        });

        this.AddCommand.Subscribe(() =>
        {

            this.Collection.Add($"Item {this.Collection.Count}");
        });

    }
}
