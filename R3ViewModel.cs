using ObservableCollections;

using R3;

using System.Threading.Tasks;

namespace R3WinUITest;

public class R3ViewModel
{
    public BindableReactiveProperty<int> Count { get; } = new();

    public ReactiveCommand<Unit> IncrementCommand { get; } = new();

    public ReactiveCommand<Unit> IncrementInTaskCommand { get; } = new();

    public ObservableList<string> Collection { get; } = ["Item 0", "Item 1"];

    public ReactiveCommand<Unit> AddCommand { get; } = new();
    public R3ViewModel()
    {
        this.IncrementCommand.Subscribe(_ => this.Count.Value++);
        this.IncrementInTaskCommand.Subscribe(_ => {
            Task.Run(() =>
            {
                this.Count.Value++;
            });
        });

        this.AddCommand.Subscribe(_ =>
        {

            this.Collection.Add($"Item {this.Collection.Count}");
        });

    }
}
