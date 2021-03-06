﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Tag system:
*/

namespace GeminiProcessor
{
    class Memory
    {
        public List<UInt32> instructions = new List<UInt32>();

        const int inputCacheSize = 8;
        const int setAssociative = 2; // 1 way or 2 way
        const int cacheSize = inputCacheSize / setAssociative;
        const int blockSize = 2;
        BlockSet[] cache = new BlockSet[cacheSize];
        private int[] stack = new int[256];

        Random rand = new Random();
        int blockNumber;
        int cacheIndex;
        int randomBlockIndex;
        int dataIndex;
        int currentTag;
        BlockSet currentBlockSet;

        int misses = 0;
        int hits = 0;

        public Memory()
        {
            for (int i = 0; i < cacheSize; i++)
            {
                cache[i] = new BlockSet(setAssociative, blockSize);
            }
        }

        public int this[int i]
        {              
            get
            {
                blockNumber = Convert.ToInt32(i / blockSize);
                cacheIndex = blockNumber % cacheSize;
                randomBlockIndex = rand.Next(setAssociative - 1); //Random Replacement Strategy
                dataIndex = i % blockSize;
                //Cache drawing http://i.imgur.com/UIgzmdn.jpg
                currentTag = blockNumber >> (int)Math.Log(cacheIndex, 2);

                currentBlockSet = cache[cacheIndex];
                
                bool hit = false;
                int hitIndex = 0;

                //Search for a tag match within the blockset
                for (int x = 0; x < setAssociative; x++)
                {
                    int tempTag = cache[cacheIndex].getTag(x);
                    if (tempTag == currentTag)
                    {
                        hit = true;
                        hitIndex = x;
                        break;
                    }
                    else
                    {
                        hit = false;
                    }
                }

                if (hit == true)
                {
                    //HIT - simply return data
                    hits++;
                    return currentBlockSet[hitIndex][dataIndex];
                }
                else
                {
                    //MISS - write data to random block within blockset
                    int[] newBlockData = currentBlockSet[randomBlockIndex];
                    newBlockData[dataIndex] = stack[i];

                    //If current block to be replaced is dirty, then write it to the stack
                    if (cache[cacheIndex].getDirty(randomBlockIndex) == true)
                    {
                        for (int index = 0; index < blockSize; index++)
                        {
                            stack[index] = cache[cacheIndex][randomBlockIndex][index];
                        }
                    }

                    cache[cacheIndex][randomBlockIndex] = newBlockData; //Random Replacement
                    cache[cacheIndex].setTag(randomBlockIndex, currentTag);
                    cache[cacheIndex].setValidBit(true); //Set valid bit of the BlockSet to be true
                    misses++;
                    return cache[cacheIndex][randomBlockIndex][dataIndex];
                }
            }
            set
            {
                blockNumber = Convert.ToInt32(i / blockSize);
                cacheIndex = blockNumber % cacheSize;
                randomBlockIndex = rand.Next(setAssociative - 1); //Random Replacement Strategy
                dataIndex = i % blockSize;
                //Cache drawing http://i.imgur.com/UIgzmdn.jpg
                currentTag = blockNumber >> (int)Math.Log(cacheIndex, 2);

                currentBlockSet = cache[cacheIndex];

                int[] blockToBeWritten = cache[cacheIndex][randomBlockIndex];
                blockToBeWritten[dataIndex] = value;

                bool hit = false;
                int hitIndex = 0;

                for (int x = 0; x < setAssociative; x++)
                {
                    int tempTag = cache[cacheIndex].getTag(x);
                    if (tempTag == currentTag)
                    {
                        hit = true;
                        hitIndex = x;
                        break;
                    }
                    else
                    {
                        hit = false;
                    }
                }

                if (hit == true)
                {
                    cache[cacheIndex][randomBlockIndex] = blockToBeWritten;
                    cache[cacheIndex].setDirty(randomBlockIndex, true);
                    hits++;
                }
                else
                {
                    misses++;
                    stack[i] = value;
                }
            }
        }

        public int getMisses()
        {
            return misses;
        }

        public int getHits()
        {
            return hits;
        }

        static int getLastEightBits(int n)
        {
            return (n & 255);
        }
        static int getValidBit(int n)
        {
            return (n & 511) >> 8;
        }
    }
}
