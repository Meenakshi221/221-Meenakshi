toFindDuplicates();

function toFindDuplicates() {
    let arry = [1, 2, 1, 3, 4, 3, 5];
    let resultToReturn = false;
    // call some function with callback function as argument
    resultToReturn = arry.some((element, index) => {
        return arry.indexOf(element) !== index
    });
    if (resultToReturn) {
        console.log('Duplicate elements exist' );
        }
        else {
            console.log('Duplicates not exist ');
            }
        }