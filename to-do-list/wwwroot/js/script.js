const input = document.querySelector("#input")
const add = document.querySelector("#add")
const container =document.querySelector("#container")

add.addEventListener('click', addItem)

// container.innerText = "hola mundo"


function addItem(e) {
    const element = document.createElement('li')
    element.innerText = input.value
    container.appendChild(element)

    input.value = ''
    
    element.addEventListener('click',function(){
      element.parentElement.removeChild(element) 
    })
  }




