class TreeNode {
    constructor(value){
        this.value = value;
        this.children = []
    }
}

// create nodes with values
const a = new TreeNode('a');
const b = new TreeNode('b');
const c = new TreeNode('c');
const d = new TreeNode('d');
const e = new TreeNode('e');
const f = new TreeNode('f');
const g = new TreeNode('g');
const h = new TreeNode('h');
const i = new TreeNode('i');
const j = new TreeNode('j');
const k = new TreeNode('k');
const l = new TreeNode('l');
const m = new TreeNode('m');


// associate root with is descendants
a.children.push(b,c,d)
b.children.push(e)
e.children.push(k,l)
c.children.push(f,g,h)
h.children.push(m)
d.children.push(i,j)


const breadthFirstSearch = (startNode) => {
    const queue = [startNode];
    while(queue.length){
        const node = queue.shift()
    console.log({'Node' : node.value})
        //callback(node)
        queue.push(node.children)
    }
}

const deapthFirstPreOrder = (startNode) => {
    //callback(startNode)
    startNode.children.forEach(node => {
    console.log({'Node' : node.value})
        deapthFirstPreOrder(node)
    });
}


const recursive = (node) => {
    console.log({'Node' : node.value})
    if(node.children){
        node.children.forEach(childNode => {
            recursive(childNode)
        })
    }
}

// console.log('Breadth First =================>')
// //breadthFirstSearch(a)
// console.log('Deapth First =================>')
// deapthFirstPreOrder(a)
// console.log('Recursive =================>')
// recursive(a)




