using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    class BlockSet
    {
        private bool validBit;
        private Block[] blocks;

        public BlockSet(int setAssociative, int blockSize)
        {
            validBit = false;
            blocks = new Block[setAssociative];
            for (int i = 0; i < setAssociative; i++)
            {
                blocks[i] = new Block(blockSize);
            }
        }

        public int[] this[int i]
        {
            get
            {
                return blocks[i].getBlock();
            }
            set
            {
                blocks[i].setBlock(value);
            }
        }

        public bool getDirty(int index)
        {
            return blocks[index].getDirty();
        }

        public void setDirty(int index, bool b)
        {
            blocks[index].setDirty(b);
        }

        public int getTag(int index)
        {
            return blocks[index].getTag();
        }

        public void setTag(int index, int tagValue)
        {
            blocks[index].setTag(tagValue);
        }

        public bool getValidBit()
        {
            return validBit;
        }

        public void setValidBit(bool b)
        {
            validBit = b;
        }

    }
}
