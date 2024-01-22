namespace Disposable;

class Program {
	static void CreateAndDisposeTemporalObject() {
		TemporalObject tmp = new();
	}
	
	static async Task Main(string[] args) {
		CreateAndDisposeTemporalObject();
		await Task.Delay(10000);
	}
}