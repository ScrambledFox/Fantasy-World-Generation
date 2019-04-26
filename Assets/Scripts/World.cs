using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World {

    string name;

    ContinentType continentType;

    float[,] heightMap;
    Color[,] biomeMap;

    public World (string name) {
        this.name = name;
    }

    public enum ContinentType {
        Pangea, Continents, Archipelago
    }

}