using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    class Block
    {
        private int tag;
        private int[] data;
        bool dirty;

        public Block(int blockSize)
        {
            data = new int[blockSize];
        }

        public bool getDirty()
        {
            return dirty;
        }
        public void setDirty(bool b)
        {
            dirty = b;
        }
        public int[] getBlock()
        {
            return data;
        }

        public void setBlock(int[] d)
        {
            data = d;
        }

        public int getTag()
        {
            return tag;
        }

        public void setTag(int n)
        {
            tag = n;
        }
    }
}
