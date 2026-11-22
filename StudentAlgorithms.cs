using System.Security.Cryptography;

namespace TspStarter;

public static class StudentAlgorithms
{
    // TASK 1: construct a nearest-neighbour tour from the requested starting city.
    // Return each city exactly once. Do not append the start city again at the end.
    // Use distances[from, to] and choose a consistent rule for ties.
    public static int[] NearestNeighbour(double[,] distances, int startCity)
    {
        throw new NotImplementedException("Implement nearest neighbour here.");
        //P, Sindhukumari. “Traveling Salesman Problem.” Medium, 25 Dec. 2022, sindhukumari.medium.com/traveling-salesman-problem-9deb6853ac6. Accessed 17 Nov. 2026.
         /*'''
             Implementing Nearest Neighbor Heuristic to solve Traveling Salesman problems
            '''
            def tspNearestNeighborHeuristic(cities, distance):
                visited = []
                minimum_distance_traveled = []

                neighbor = 'A'
                start_node_index = cities.index(neighbor)

                no_nodes = len(cities)
                noN = 0
                while noN < no_nodes and neighbor not in visited:

                    visited.append(neighbor)
                    neighbor_index = cities.index(neighbor)
                    noNeigjbour = 0
                    MIN = 0

                    while noNeigjbour < len(distance[neighbor_index]):

                        if cities[noNeigjbour] not in visited: #look for unvisitied cities.
                            if MIN == 0:
                                MIN = distance[neighbor_index][noNeigjbour]
                                neighbor = cities[noNeigjbour]
                            else:
                                min_distance = min(distance[neighbor_index][noNeigjbour], MIN)
                                if distance[neighbor_index][noNeigjbour] < MIN:
                                    MIN = min_distance
                                    neighbor = cities[noNeigjbour]
                        noNeigjbour += 1
                    minimum_distance_traveled.append(MIN)
                    noN += 1
                last_node_index = cities.index(visited[-1])
                minimum_distance_traveled[-1] = distance[last_node_index][start_node_index]
                print('Shortest route : ', " -> ".join(visited))
                for _i in range(len(visited)):
                    print("City " + visited[_i] + "'s Nearest Neighbor's Distance is ", minimum_distance_traveled[_i])
                print("total traveled distance: ", sum(minimum_distance_traveled))



            cities = ['A', 'B', 'C', 'D', 'E']
            distance = [[0, 60, 217, 164, 69],
                        [60, 0, 290, 201, 79],
                        [217, 290, 0, 113, 303],
                        [164, 201, 113, 0, 196],
                        [69, 79, 303, 196, 0]]

            tspNearestNeighborHeuristic(cities, distance)
         */
    }

    // TASK 2: improve the supplied route using 2-opt.
    // Copy initialRoute before editing; preserve the start city and do not worsen cost.
    // The loaded EUC_2D matrices are symmetric. Explain your move-selection/stopping policy.
    public static int[] TwoOpt(double[,] distances, int[] initialRoute)
    {
        //Davis, Adam. “Traveling Salesman Problem With the 2 - Opt Algorithm.” Medium, 19 May 2022, slowandsteadybrain.medium.com / traveling - salesman - problem - ce78187cf1f3.Accessed 22 Nov. 2026.
        throw new NotImplementedException("Implement 2-opt here.");
    }
}
