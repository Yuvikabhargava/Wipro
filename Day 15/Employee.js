function getEmployee(emp) {
    return "".concat(emp.id, " ").concat(emp.name, " ").concat(emp.dept);
}
var emp1 = {
    id: 11,
    name: 'Anu',
    dept: 'HR'
};
console.log(getEmployee(emp1));
