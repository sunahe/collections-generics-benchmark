using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;


BenchmarkRunner.Run<GenericsBaby>();


[SimpleJob(RuntimeMoniker.Net48)]
[SimpleJob(RuntimeMoniker.Net70)]
[MemoryDiagnoser]
public class GenericsBaby
{
    private List<object> list = null!;

    [Params(10, 100, 10000)]
    public int ListSize;

    [GlobalSetup]
    public void GlobalSetup()
    {
        list = new List<object>(ListSize);
        for (int i = 0; i < ListSize; i++)
            list.Add(new object());
    }

    [Benchmark]
    public void ForeachInList()
    {
        Run(list);

        static void Run(List<object> list)
        {
            foreach (var item in list) { }
        }
    }

    [Benchmark]
    public void ForeachInEnumerable()
    {
        Run(list);

        static void Run(IEnumerable<object> list)
        {
            foreach (var item in list) { }
        }
    }

    [Benchmark]
    public void ForeachInGenericIEnumerable()
    {
        Run<object, List<object>>(list);

        static void Run<T, TList>(TList list)
            where T : class
            where TList : IEnumerable<T>
        {
            foreach (var item in list) { }
        }
    }

    [Benchmark]
    public void ForeachInGenericIList()
    {
        Run<object, List<object>>(list);

        static void Run<T, TList>(TList list)
            where T : class
            where TList : IList<T>
        {
            foreach (var item in list) { }
        }
    }
}
