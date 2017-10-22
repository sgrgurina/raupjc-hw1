using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class IntegerList : IIntegerList
    {
        private int[] internalStorage;
        private int nextIndex = 0;

        public IntegerList()
        {
            internalStorage = new int[4];
        }

        public IntegerList(int initialSize)
        {
            if (initialSize < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            internalStorage = new int[initialSize];
        }

        public void Add(int item)
        {
            if (nextIndex >= internalStorage.Length)
            {
                int[] newStorage = new int[internalStorage.Length*2];

                for(int i=0; i<nextIndex; i++)
                {
                    newStorage[i] = internalStorage[i];
                }
                internalStorage = newStorage;
            }

            internalStorage[nextIndex] = item;
            nextIndex++;

        }

        public bool Remove(int item)
        {
            int index = IndexOf(item);

            return RemoveAt(index);
        }

        public bool RemoveAt(int index)
        {
            if (index >= 0 && index<nextIndex)
            {
                for (int i = index; i < nextIndex-1; i++)
                {
                    internalStorage[i] = internalStorage[i + 1];
                }
                nextIndex--;
                return true;
            }

            return false;
        }

        public int GetElement(int index)
        {

            if (index>=0 && index<nextIndex)
            {
                return internalStorage[index];
            }

            throw new IndexOutOfRangeException();
            
        }

        public int IndexOf(int item)
        {
            int index = -1;

            for (int i = 0; i < nextIndex; i++)
            {
                if (internalStorage[i] == item)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public int Count
        {
            get => nextIndex;
        }

        public void Clear()
        {
            nextIndex = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < nextIndex; i++)
            {
                if (internalStorage[i] == item)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
