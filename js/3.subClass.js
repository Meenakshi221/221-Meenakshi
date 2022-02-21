class Animal{
    constructor(name){
        this.name=name;
    }

    speak(){
        console.log(`${this.name} make a noise. `);
    }
}
var animal =new Animal("Tiger");
animal.speak();