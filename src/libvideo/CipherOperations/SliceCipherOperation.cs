﻿// Code from YoutubeExplode (LGPL https://github.com/Tyrrrz/YoutubeExplode/blob/master/License.txt)


namespace VideoLibrary.CipherOperations
{
    internal class SliceCipherOperation : ICipherOperation
    {
        private readonly int _index;

        public SliceCipherOperation(int index)
        {
            _index = index;
        }

        public string Decipher(string input)
        {
            return input.Substring(_index);
        }
    }
}
