class getOrderedName{
    constructor(name){
        this.name=name;
    }

    getProductDetails(){
        console.log(`${this.name} on Amazon `);
    }
}

class Ordered extends getOrderedName{
    constructor(name){
        super(name)
    }
    YourOrdered(){
        console.log(`${this.name} is Iphone 13 Mini `);
    }
}

var p = new Ordered(" your Order  ");
p.getProductDetails();
p.YourOrdered();