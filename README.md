//Begin
function begin1() {
    console.log("Begin1 ◦ . Дана сторона квадрата a. Найти его периметр P = 4·a.")
    var a = 2
    console.log("a= " + a)
    console.log("p=" + a * 4)
}

function begin2() {
    console.log("Begin2 ◦ . Дана сторона квадрата a. Найти его площадь S = a 2 .")
    var a = 2
    console.log("a= " + a)
    console.log("s=" + a ** 2)
}

function begin3() {
    console.log("Begin3 ◦ . Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).")
    var a = 2
    var b = 3
    console.log("a= " + a)
    console.log("b= " + b)
    console.log("ploshad pryamougolnika=" + a * b)
    console.log("perimetr pryamougolnika=" + 2 * (a + b))
}

function begin4() {
    console.log("Begin4 ◦ . Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14.")
    var p = 3.14
    var d = 2
    console.log("p= " + p)
    console.log("d= " + d)
    console.log("dlina= " + p * d)
}

function begin5() {
    console.log("Begin5 ◦ . Дана длина ребра куба a. Найти объем куба V = a 3 и площадь его поверхности S = 6·a 2")
    var a = 2
    console.log("a= " + a)
    console.log("obem= " + a ** 3)
    console.log("ploshad=" + 6 * a ** 2)
}

function begin6() {
    console.log("Begin6 ◦ . Даны длины ребер a, b, c прямоугольного параллелепипеда. Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).")
    var a = 2
    var b = 3
    var c = 4
    console.log("a= " + a)
    console.log("b= " + b)
    console.log("c= " + c)
    console.log("obem= " + a * b * c)
    console.log("ploshad= " + 2 * (a * b + b * c + a * c))
}

function begin7() {
    console.log("Begin7 ◦ . Найти длину окружности L и площадь круга S заданного радиуса R:")
    var r = 3
    var p = 3.14
    console.log("R= " + r)
    console.log("dlina= " + 2 * p * r)
    console.log("ploshad=" + p * r ** 2)
}

function begin8() {
    console.log("Begin8 ◦ . Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2.")
    var a = 12
    var b = 32
    console.log("a= " + a)
    console.log("b= " + b)
    console.log("среднее арифметическое a,b= " + (a + b) / 2)
}

function begin9() {
    console.log("Begin9 ◦ . Даны два неотрицательных числа a и b. Найти их среднее геометри ческое, то есть квадратный корень из их произведения: a·b.")
    var a = 8
    var b = 2
    console.log("a= " + a)
    console.log("b= " + b)
    console.log("среднее геометрическое a,b= " + Math.sqrt(a * b))
}

function begin10() {
    console.log("Begin10 ◦ . Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.")
    var a = 2
    var b = 3
    console.log("a= " + a)
    console.log("b= " + b)
    console.log("summa= " + (a + b))
    console.log("raznost= " + (a - b))
    console.log("summa= " + Math.abs(a + b))
}

function begin11() {
    var a = 5
    var b = 2
    if (a != 0, b != 0) {
        console.log("summa=" + Math.abs(a + b))
        console.log("raznost=" + Math.abs(a - b))
        console.log("proizvod=" + Math.abs(a * b))
        console.log("chast=" + Math.abs(a / b))
    }
}

function begin12() {
    var a = 5
    var b = 2
    c = Math.sqrt(a ** 2 + b ** 2)
    p = a + b + c
    console.log("c=" + c)
    console.log("p=" + p)
}

function begin13() {
    var r1 = 3
    var r2 = 2
    var p = 3.14
    if (r1 > r2) {
        s1 = p * r1 ** 2
        s2 = p * r2 ** 2
        s3 = s1 - s2
        console.log("s1=" + s1)
        console.log("s2=" + s2)
        console.log("s3=" + s3)
    } else {
        console.log("r1<r2")
    }
}

function begin14() {
    var l = 2
    var p = 3.14
    r = l / 2 * p
    s = p * r ** 2
    console.log("r=" + r)
    console.log("s=" + s)
}

function begin15() {
    var s = 2
    p = 3.14
    r = Math.sqrt(s / p)
    d = 2 * r
    l = 2 * p * r
    console.log("d=" + d)
    console.log("l=" + l)
}

function begin16() {
    var x1 = 2
    var x2 = 3
    console.log("mod=" + Math.abs(x2 - x1))
}

function begin17() {
    var a = 2
    var b = 3
    var c = 4
    ac = Math.abs(a - c)
    bc = Math.abs(b - c)
    s = ac + bc
    console.log("s=" + s)
}

function begin18() {
    var a = 2
    var b = 3
    var c = 4
    ac = Math.abs(a - c)
    bc = Math.abs(b - c)
    p = ac * bc
    console.log("P=" + p)
}

function begin19() {
    var x1 = 2
    var x2 = 3
    var y1 = 4
    var y2 = 5
    x = Math.abs(x1 - x2)
    y = Math.abs(y1 - y2)
    console.log("p=" + (x + y))
    console.log("s=" + (x * y))
}

function begin20() {
    var x1 = 2
    var x2 = 3
    var y1 = 4
    var y2 = 5
    r = Math.sqrt((Math.abs(x2 - x1)) ** 2 + (Math.abs(y2 - y1)) ** 2)
    console.log("rasstoyanie=" + r)
}

function begin21() {
    var x1 = 2
    var x2 = 3
    var x3 = 4
    var y1 = 5
    var y2 = 6
    var y3 = 7
    a = Math.sqrt(Math.abs(x1 - x2) + Math.abs(y1 - y2))
    b = Math.sqrt(Math.abs(x2 - x3) + Math.abs(y2 - y3))
    c = Math.sqrt(Math.abs(x3 - x1) + Math.abs(y3 - y1))
    p = (a + b + c) / 2
    s = Math.sqrt(p * (p - a) * (p - b) * (p - c))
    console.log("s=" + s)
    console.log("p=" + p)
}

function begin22() {
    var a = 2
    var b = 3
    var c = b
    var d = a
    var a = c
    var b = d
    console.log("a=" + a)
    console.log("b=" + b)
}

function begin23() {
    var a = 2
    var b = 3
    var c = 4
    var d = a
    var e = b
    var f = c
    var a = e
    var b = f
    var c = d
    console.log("a=" + a)
    console.log("b=" + b)
    console.log("c=" + c)
}

function begin24() {
    var a = 2
    var b = 3
    var c = 4
    var d = a
    var e = b
    var f = c
    var a = f
    var b = d
    var c = e
    console.log("a=" + a)
    console.log("b=" + b)
    console.log("c=" + c)
}

function begin25() {
    var x = 2
    var y = 3 * x ** 6 - 6 * x ** 2 - 7
    console.log("y=" + y)
}

function begin26() {
    var x = 2
    var y = 4 * (x - 3) ** 6 - 7 * (x - 3) ** 3 + 2
    console.log("y=" + y)
}

function begin27() {
    var a = 2
    var a2 = a * a
    var a4 = a2 * a2
    var a8 = a4 * a4
    console.log("a8=" + a8)
}

function begin28() {
    var a = 2
    var a2 = a * a
    var a3 = a2 * a
    var a5 = a3 * a2
    var a10 = a5 * a5
    var a15 = a10 * a5
    console.log("a15=" + a15)
}

function begin29() {
    var a = 270
    var p = 3.14
    var rad = a * p / 180
    console.log("radian" + a + "=" + rad)
}

function begin30() {
    var a = 270
    var p = 3.14
    var rad = a * 2 * p / 180
    console.log("radian" + a + "=" + rad)
}

function begin31() {
    var Tf = 50
    var Tc = (Tf - 32) * 5 / 9
    console.log("Tc=" + Tc)
}

function begin32() {
    var Tc = 50
    var Tf = (9 / 5 * Tc) + 32
    console.log("Tf=" + Tf)
}

function begin33() {
    var x = 2
    var a = 40
    var y = 4
    var all = (1 + y) * a / x
    console.log("all=" + all)
}

function begin34() {
    var x = 2
    var a = 60
    var y = 2
    var b = 30
    var all = (a / x) + (b / y)
    var raz = (a / x) - (b / y)
    console.log("price=" + all)
    console.log("skolko daroje=" + raz)
}

function begin35() {
    var v = 40
    var u = 30
    var t1 = 10
    var t2 = 12
    var s = v * t1 + (v - u) * t2
    console.log("s=" + s)
}

function begin36() {
    var v1 = 50
    var v2 = 60
    var s = 30
    var v = v2 + v1
    var t = s / v
    console.log("t=" + t)
}

function begin37() {
    var v1 = 50
    var v2 = 60
    var s = 30
    var v = v2 - v1
    var t = s / v
    console.log("t=" + t)
}

function begin38() {
    var a = 2
    var b = 3
    if (a != 0) {
        var x = -b / a
        console.log("x=" + x)
    }
}

function begin39() {
    var a = 2
    var b = 5
    var c = 2
    if (a != 0) {
        var d = Math.sqrt(b ** 2 - 4 * a * c)
        console.log("d=" + d)
        var x1 = (-b + d) / 2 * a
        var x2 = (-b - d) / 2 * a
        console.log("x1=" + x1)
        console.log("x2=" + x2)
    }
}

function begin40() {
    var a1 = 2
    var a2 = 3
    var b1 = 4
    var b2 = 5
    var c1 = 6
    var c2 = 7
    var d = a1 * b2 - a2 * b1
    var x = (c1 * b2 - c2 * b1) / d
    var y = (a1 * c2 - a2 * c1) / d
    console.log("d=" + d)
    console.log("x=" + x)
    console.log("y=" + y)
}

function integer1() {
    var l = 122
    var m = l * 1 / 100
    console.log("m=" + m)
}

function integer2() {
    var m = 2314
    var t = m / 1000
    console.log("t=" + t)
}

function integer3() {
    var b = 27124
    var k = b / 1024
    console.log("k=" + k)
}

function integer4() {
    var a = 30
    var b = 6
    var c = a / b
    console.log("kolichestvo=" + c)
}

function integer5() {
    let b = 6
    let c = 5
    let a = b * c
    console.log("a=" + a)
}

function integer6() {
    let a = 23
    let a2 = a % 10
    let a1 = (a - a2) / 10

    console.log("a=" + a)
    console.log("a1=" + a1)
    console.log("a2=" + a2)
}

function integer7() {
    let a = 58
    let tens = Math.floor(a / 10)
    let units = a % 10
    console.log(tens)
    console.log(units)
    let sum = tens + units
    let proizvod = tens * units
    console.log("sum=" + sum)
    console.log("proisvod=" + proizvod)
}

function integer8() {
    let a = 58
    let tens = Math.floor(a / 10)
    let units = a % 10
    console.log(tens)
    console.log(units)
    let a1 = units * 10 + tens
    console.log("a1=" + a1)
}

function integer9() {
    let sotin = 435
    let sotin1 = Math.floor(sotin / 100)
    console.log("sotina=" + sotin)
    console.log("sotin1=" + sotin1)
}

function integer10() {
    let a = 235
    console.log(a)
    let a3 = a % 10
    let a12 = Math.floor(a / 10)
    console.log("a3=" + a3)
    let a2 = a12 % 10
    console.log("a2=" + a2)
}

function integer11() {
    let a = 541
    console.log(a)
    let a1 = Math.floor(a / 100)
    let a2 = (Math.floor(a / 10)) % 10
    let a3 = a % 10
    console.log(a1)
    console.log(a2)
    console.log(a3)
}

function integer12() {
    let a = 893
    console.log(a)
    let a1 = Math.floor(a / 100)
    let a2 = (Math.floor(a / 10)) % 10
    let a3 = a % 10
    console.log(a1)
    console.log(a2)
    console.log(a3)
    let a321 = (a3 * 100) + (a2 * 10) + a1
    console.log(a321)
}

function integer13() {
    let a = 541
    console.log(a)
    let a1 = Math.floor(a / 100)
    let a2 = (Math.floor(a / 10)) % 10
    let a3 = a % 10
    console.log(a1)
    console.log(a2)
    console.log(a3)
    let a231 = (a2 * 100) + (a3 * 10) + a1
    console.log(a231)
}

function integer14() {
    let a = 789
    console.log(a)
    let a1 = Math.floor(a / 100)
    let a2 = (Math.floor(a / 10)) % 10
    let a3 = a % 10
    console.log(a1)
    console.log(a2)
    console.log(a3)
    let a312 = (a3 * 100) + (a1 * 10) + a2
    console.log(a312)
}

function integer15() {
    let a = 123
    console.log(a)
    let a1 = Math.floor(a / 100)
    let a2 = (Math.floor(a / 10)) % 10
    let a3 = a % 10
    console.log(a1)
    console.log(a2)
    console.log(a3)
    let a213 = (a2 * 100) + (a1 * 10) + a3
    console.log(a213)
}

function integer16() {
    let a = 123
    console.log(a)
    let a1 = Math.floor(a / 100)
    let a2 = (Math.floor(a / 10)) % 10
    let a3 = a % 10
    console.log(a1)
    console.log(a2)
    console.log(a3)
    let a132 = (a1 * 100) + (a3 * 10) + a2
    console.log(a132)
}

function integer17() {
    let a = 12345
    if (a > 999) {
        let a234 = Math.floor((a % 1000) / 100)
        console.log(a234)
    } else {
        console.log("a<9999")
    }
}

function integer18() {
    let a = 12340
    if (a > 999) {
        let a234 = Math.floor((a % 10000) / 1000)
        console.log(a234)
    } else {
        console.log("a<999")
    }
}

function integer19() {
    let s = 4000
    let m = Math.floor(s / 60)
    console.log("polniy minut=", m)

}

function integer20() {
    let s = 5420
    let min = s / 60
    let chas = min / 60
    console.log("colichestvo polnikh chasov=", chas)
}

function integer21() {

}
