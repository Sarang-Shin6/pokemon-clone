using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    public PokemonBase Base { get; set; }
    public int Level { get; set; }

    public int Hp { get; set; }

    public List<Move> Moves { get; set; }

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        Base = pBase;
        Level = pLevel;
        Hp = MaxHp;

        Moves = new List<Move>();
        foreach (var move in Base.LearnableMoves)
        {
            if (move.Level <= Level)
            {
                Moves.Add(new Move(move.Base));

                if (Moves.Count >= 4)
                {
                    break;
                }
            }
        }
    }

    public int Attack { get => calcStat(Base.Attack); }
    public int Defense { get => calcStat(Base.Defense); }
    public int SpAttack { get => calcStat(Base.SpAttack); }
    public int SpDefense { get => calcStat(Base.SpDefense); }
    public int Speed { get => calcStat(Base.Speed); }
    public int MaxHp { get => calcStat(Base.MaxHp, true); }

    public int calcStat(int prop, bool hp = false)
    {
        var current = Mathf.FloorToInt((prop * Level / 100f));
        return hp ? current + 10 : current + 5;
    }
}
