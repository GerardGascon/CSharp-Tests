# Disposable

Small test to see if Disposable() from IDisposables is automatically called right after
loosing scope.

### Result

The Dispose() method doesn't seem to be called automatically, even with a destroyer
method inside the class.