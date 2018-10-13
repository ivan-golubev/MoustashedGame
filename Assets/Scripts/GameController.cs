using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField] private Transform[] playerLocations;
    [SerializeField] private Player playerPrefab;
    [SerializeField] private Transform playersRoot;

    private Dictionary<int, Player> players = new Dictionary<int, Player>();
    
    void Start () {
        foreach (var t in playerLocations) {
            var player = Instantiate(playerPrefab);
            player.transform.SetParent(playersRoot);
            player.transform.position = t.position;
            player.transform.localRotation = t.localRotation;
            players[player.GetId()] = player;
        }
	}
	
}
