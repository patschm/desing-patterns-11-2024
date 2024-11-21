using System.Collections;

namespace CustomCollections;

public class SpecialCollectionIterator<T> : IEnumerator<T>
{
    private readonly SpecialCollection<T> _specialCollection;
    private int _index = 0;

    public SpecialCollectionIterator(SpecialCollection<T> specialCollection)
    {
        _specialCollection = specialCollection;
    }

    public T Current => _specialCollection[_index];

    object IEnumerator.Current => _specialCollection[_index];

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        _index++;
        if (_index >= _specialCollection.Count )
        {
            _index = _specialCollection.Count - 1;
            return false;
        }
        return true;
    }

    public void Reset()
    {
       _index = 0;
    }
}
