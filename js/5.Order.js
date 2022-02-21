class getOrderedName{
    constructor(name){
        this.name=name;
    }

    productDetails(){
        console.log(`${this.name} ordere this product .`);
    }

}
var ord = new getOrderedName("Succesfull");
ord.productDetails(); 