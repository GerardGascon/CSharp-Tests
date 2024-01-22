namespace Disposable;

public class TemporalObject : IDisposable {

	public TemporalObject() {
		Console.WriteLine("Object Got Created");
	}

	~TemporalObject() {
		Console.WriteLine("Object Got Destroyed");
		Dispose();
	}
	
	public void Dispose() {
		Console.WriteLine("Object Got Disposed");
	}
}