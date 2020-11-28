using System;
using System.Collections;
using System.Collections.Generic;

namespace MyFirstGame
{
    public enum Name
    {
        wall, space, nothing, player, dollar, enemy
    }

    public class Texture 
    {
        public readonly char symbol;
        public readonly ConsoleColor foregroundColor;
        public readonly ConsoleColor backgroundColor;


        // Сделать приватный конструктор, чтобы никто больше не мог создавать никаких текстур, кроме уже существующих
        #region Class Constructor
        public Texture(Name name)
        {
            TextureDictionary.TryGetValue(name, out Texture temp);

            this.symbol = temp.symbol;
            this.foregroundColor = temp.foregroundColor;
            this.backgroundColor = temp.backgroundColor;
        }
        private Texture(char symbol, ConsoleColor backgroundColor)
        {
            this.symbol = symbol;
            this.backgroundColor = backgroundColor;
            this.foregroundColor = backgroundColor;
        }
        private Texture(char symbol, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
            : this(symbol, backgroundColor)
        {
            this.foregroundColor = foregroundColor;
        }
        #endregion

        // Enum of Textures
       

        public Texture this[Name key]
        {
            get => TextureDictionary[key];
        }

        private Dictionary<Name, Texture> TextureDictionary = new Dictionary<Name, Texture>()
        {
            {Name.wall , new Texture('#', ConsoleColor.DarkYellow, ConsoleColor.Yellow)},
            {Name.space, new Texture(' ', ConsoleColor.White)},
            {Name.nothing, new Texture(' ', ConsoleColor.Black)},
            {Name.player, new Texture('0', ConsoleColor.White, ConsoleColor.DarkBlue)},
            {Name.dollar, new Texture('$', ConsoleColor.White, ConsoleColor.DarkGreen)},
        };

       
    }
}
