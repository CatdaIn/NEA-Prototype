using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph
{
    private int[,] adjacencyMatrix;
    private int numNodes;

    public Graph(int numNodes){
        this.numNodes = numNodes;
        this.adjacencyMatrix = new int[numNodes, numNodes];
    }

    // Creates an adjacency between 2 nodes
    public void CreateAdjacency(int node1, int node2){
        adjacencyMatrix[node1, node2] = 1;
        adjacencyMatrix[node2, node1] = 1;
    }

    // Returns true if an adjacency exists, false otherwise
    public bool CheckAdjacency(int node1, int node2){
        return adjacencyMatrix[node1, node2] == 1;
    }

    // Removes an adjacency between 2 nodes
    public void RemoveAdjacency(int node1, int node2){
        adjacencyMatrix[node1, node2] = 0;
        adjacencyMatrix[node2, node1] = 0;
    }

    // Return the number of adjacencies of a given node
    public int NumberOfAdjacencies(int node1){
        int returnNumber = 0;

        for (int i = 0; i < this.numNodes; i++){
            // 1 marks adjacency, 0 marks no adjacency
            // Therefore, adding the value in the matrix, adds 1 if there is an adjacency, 0 otherwise
            returnNumber += this.adjacencyMatrix[node1, i];
        }

        return returnNumber;
    }
}
