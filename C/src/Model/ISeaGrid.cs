using System;

namespace MyGame.src.Model
{
    // '' <summary>
    // '' The ISeaGrid defines the read only interface of a Grid. This
    // '' allows each player to see and attack their opponents grid.
    // '' </summary>
    public interface ISeaGrid
    {

        int Width { get; }
        int Height { get; }

        EventHandler EventChanged();
        TileView Item(int row, int column);
        AttackResult HitTile(int row, int column);

    }
}
