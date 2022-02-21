
const arr = [1, 2, 1, 3, 4, 3, 5];

const toFindDuplicates = arr => arr.filter((item, index) => arr.indexOf(item) !== index)
const duplicateElements = toFindDuplicates(arr);
console.log(duplicateElements);

