using System;

namespace tabuleiro
{
    class TabuleiroException : Exception // classe personalizada que recebe uma msg e repassa a msg para classe Exception.
    {
        public TabuleiroException(string msg) : base (msg)
        {

        }

    }
}
