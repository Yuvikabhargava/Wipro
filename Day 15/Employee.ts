interface Employee{
    id?:number,//optional property
    name: string,
    dept:string
}


function getEmployee(emp:Employee)
{
    return `${emp.id} ${emp.name} ${emp.dept}`
}

let emp1 = {
    id:11,
    name:'Anu',
    dept:'HR'
}
console.log(getEmployee(emp1))

