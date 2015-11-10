﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MonoGame
{
    class TileFactory
    {
        public enum TileType
        {
            // tiles
            treeTile, wallTile,

            // ledges
            ledgeLeftCurve, ledgeRightCurve, ledgeLeftEnd, ledgeRightEnd, ledgeMiddle
        }

        SpriteFactory factory;
        ITileState state;

        public TileFactory()
        {
        }

        public Tile builder(TileType type, Vector2 location)
        {
            factory = new SpriteFactory();
            if (type == TileType.treeTile)
            {
                state = new GenericTileState(SpriteFactory.sprites.treeTile);
            }
            if (type == TileType.wallTile)
            {
                state = new GenericTileState(SpriteFactory.sprites.wallTile);
            }
            if (type == TileType.ledgeLeftCurve)
            {
                state = new GenericTileState(SpriteFactory.sprites.ledgeLeftCurve);
            }
            if (type == TileType.ledgeLeftEnd)
            {
                state = new GenericTileState(SpriteFactory.sprites.ledgeLeftEnd);
            }
            if (type == TileType.ledgeMiddle)
            {
                state = new GenericTileState(SpriteFactory.sprites.ledgeMiddle);
            }
            if (type == TileType.ledgeRightCurve)
            {
                state = new GenericTileState(SpriteFactory.sprites.ledgeRightCurve);
            }
            if (type == TileType.ledgeRightEnd)
            {
                state = new GenericTileState(SpriteFactory.sprites.ledgeRightEnd);
            }
            Tile product = new Tile(state, location);
            return product;
        }
    }
}
