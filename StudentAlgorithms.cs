using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TspStarter;

public static class StudentAlgorithms
{
    // TASK 1: construct a nearest-neighbour tour from the requested starting city.
    // Return each city exactly once. Do not append the start city again at the end.
    // Use distances[from, to] and choose a consistent rule for ties.
    public static int[] NearestNeighbour(double[,] distances, int startCity)
    {
        //throw new NotImplementedException("Implement nearest neighbour here.");
        //computer geek. ““Master the Nearest Neighbour TSP Algorithm With Step-by-Step Examples and Source Code.”” Computer Geek, 24 Aug. 2024, compgeek.co.in/nearest-neighbour-problem/. Accessed 22 Nov. 2026.
        
        double[] visited = new double[distances.Length];  // Array to mark visited cities
        int[] tour = new int[10];          // Array to store the tour
        int totalDistance = 0;
        int currentCity = 0;           // Starting city
        int nearestCity;
        int i, j;

        // Initialize
        visited[currentCity] = 1;       // Mark the starting city as visited
        tour[0] = currentCity;
        int tourLength = 1;

        // Iterative Process
        for (i = 1; i < n; i++)
        {
            int minDistance = 999999;   // Large number for comparison
            nearestCity = -1;

            // Find the nearest unvisited city
            for (j = 0; j < n; j++)
            {
                if (!visited[j] && distances[currentCity][j] < minDistance)
                {
                    minDistance = distanceMatrix[currentCity][j];
                    nearestCity = j;
                }
            }
            // Move to the nearest city
            visited[nearestCity] = 1;
            tour[tourLength++] = nearestCity;
            totalDistance += minDistance;
            currentCity = nearestCity;
        }

        // Return to the starting city
        totalDistance += distanceMatrix[currentCity][0];
        tour[tourLength] = 0;

        // Output the Tour
        printf(“Tour: “);

        for (i = 0; i <= tourLength; i++)
        {
            printf(“% d “, tour[i]);
        }
        printf(“\nTotal Distance: % d\n”, totalDistance);

        return ;
    }

    /*
     * def nearest_neighbor_tsp(distances):
    n = len(distances)
    visited = [False] * n
    route = [0]
    visited[0] = True
    total_distance = 0

    for _ in range(1, n):
        last = route[-1]
        nearest = None
        min_dist = float('inf')
        for i in range(n):
            if not visited[i] and distances[last][i] < min_dist:
                min_dist = distances[last][i]
                nearest = i
        route.append(nearest)
        visited[nearest] = True
        total_distance += min_dist

    total_distance += distances[route[-1]][0]
    route.append(0)
    return route, total_distance

distances = [
    [0, 2, 2, 5, 9, 3],
    [2, 0, 4, 6, 7, 8],
    [2, 4, 0, 8, 6, 3],
    [5, 6, 8, 0, 4, 9],
    [9, 7, 6, 4, 0, 10],
    [3, 8, 3, 9, 10, 0]
]

route, total_distance = nearest_neighbor_tsp(distances)
print("Route:", route)
print("Total distance:", total_distance)
     */
    // TASK 2: improve the supplied route using 2-opt.
    // Copy initialRoute before editing; preserve the start city and do not worsen cost.
    // The loaded EUC_2D matrices are symmetric. Explain your move-selection/stopping policy.
    public static int[] TwoOpt(double[,] distances, int[] initialRoute)
    {
        //Davis, Adam. “Traveling Salesman Problem With the 2 - Opt Algorithm.” Medium, 19 May 2022, slowandsteadybrain.medium.com / traveling - salesman - problem - ce78187cf1f3.Accessed 22 Nov. 2026.
        throw new NotImplementedException("Implement 2-opt here.");
    }
}
