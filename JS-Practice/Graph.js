const graph = {
  f: ['g', 'i'],
  g: ['h'],
  h: [],
  i: ['g', 'k'],
  j: ['i'],
  k: []
};

const deapthFirstGraphSearch = (graph , src , dist) => {
    if(src == dist) return true;

    for(const neibor of graph[src]){
        return deapthFirstGraphSearch(graph , neibor, dist)
    }
    return false

}

console.log(deapthFirstGraphSearch(graph , 'f' , 'k'))