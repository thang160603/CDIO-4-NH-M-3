const adressbtn = document.querySelector('#adress-form')
const adressclose = document.querySelector('#adress-close')

const adressregisrtbtn = document.querySelector('#adress-regisrt')
const adresscloseregisrt = document.querySelector('#adress-close1')


const adressloginbtn = document.querySelector('#adress-login')
const adresscloselogin = document.querySelector('#adress-close2')

const adresscartbtn = document.querySelector('#adress-cart')
const adressclosecart = document.querySelector('#adress-close3')

const adressthongbaobtn = document.querySelector('#adress-thongbao')
const adressclosethongbao = document.querySelector('#adress-close4')

const adresshelpbtn = document.querySelector('#adress-help')
const adressclosehelp = document.querySelector('#adress-close5')

const adresshistorybtn = document.querySelector('#adress-history')
const adressclosehistory = document.querySelector('#adress-close6')



const btndathang = document.querySelector(".adress-dat-hang");
btndathang.addEventListener("click", (e) => {
    e.preventDefault();
    window.location.href = "dathang.html";

});

const btndangxuat = document.querySelector(".dang-xuat");
btndangxuat.addEventListener("click", (e) => {
    e.preventDefault();
    window.location.href = "use.html";

});
const btndiachinhanhang = document.querySelector(".nhan-hang");
btndiachinhanhang.addEventListener("click", (e) => {
    e.preventDefault();
    window.location.href = "diachinhanhang.html";

});
const btnthongtintk = document.querySelector(".thong-tin-tk");
btnthongtintk.addEventListener("click", (e) => {
    e.preventDefault();
    window.location.href = "thongtintk.html";

});
const btnreset = document.querySelector(".reset");
btnreset.addEventListener("click", (e) => {
    e.preventDefault();
    window.location.href = "text.html";

});


// const btntrolai = document.querySelector(".adress-reset");
// btntrolai.addEventListener("click", (e) =>{
//     e.preventDefault();
//     window.location.href = "text.html";

//   });
//   btnlogin.addEventListener("click", (e) =>{
//     e.preventDefault();
//     window.location.href = "thanhtoan.html";

//   });



const btn = document.querySelectorAll("button")
// console.log(btnthemvaogio)
btn.forEach(function (button, index) {
    button.addEventListener("click", function (event) {
        {
            var product = event.target.parentElement
            var productImg = product.querySelector("img").src
            var productName = product.querySelector(".product-gallery-one-content-product-item-text li:nth-child(2)").innerText
            var productPrice = product.querySelector(".product-gallery-one-content-product-item-text li:nth-child(5)").innerText
            addcart(productImg, productName, productPrice)
        }
    })
})


function addcart(productImg, productName, productPrice) {
    var addtr = document.createElement("tr")
    var cartItem = document.querySelectorAll("tbody tr ")
    alert("Thêm Sản Phẩm Thành Công")
    for (var i = 0; i < cartItem.length; i++) {
        var productT = document.querySelectorAll(".name")
        if (productT[i].innerHTML == productName) {
            alert("Sản Phẩm Đã Có Trong Giỏ Hàng ")
            return
        }
    }
    var trcontent = '<tr><td style="display: flex; align-items: center;"><img style="width: 70px" src="' + productImg + '" alt=""><span class= "name">' + productName + '</span></td><td><p><span class ="prices">' + productPrice + '</span><sup>đ</sup></p></td><td><input style="width:11% ;outline: none;" type="number" value="1" min="1"></td><td style="cursor: pointer;"><span class= "cart-delete"><i class="fa-solid fa-trash"></i></span></td></tr>'
    addtr.innerHTML = trcontent
    var cartTable = document.querySelector("tbody")
    // console.log(cartTable)
    cartTable.append(addtr)
    carttotal()
    deleteCart()


}

function carttotal() {
    var cartItem = document.querySelectorAll("tbody tr ")
    var totalC = 0
    for (var i = 0; i < cartItem.length; i++) {
        var inputValue = cartItem[i].querySelector("input").value
        var productPrice = cartItem[i].querySelector(".prices").innerHTML
        totalA = inputValue * productPrice * 1000
        totalC = totalC + totalA
        //  totalD = totalC.toLocaleString('de-DE')

    }
    var cartlotalA = document.querySelector(".price-total span")
    cartlotalA.innerHTML = totalC.toLocaleString('de-DE')
    inputchange()
}
function deleteCart() {
    var cartItem = document.querySelectorAll("tbody tr ")
    for (var i = 0; i < cartItem.length; i++) {
        var productT = document.querySelectorAll(".cart-delete")
        productT[i].addEventListener("click", function (event) {
            var cartDelete = event.target
            var cartitemR = cartDelete.parentElement.parentElement.parentElement
            cartitemR.remove()
            carttotal()
            // console.log(cartitemR)
        })
    }
}
function inputchange() {
    var cartItem = document.querySelectorAll("tbody tr ")
    for (var i = 0; i < cartItem.length; i++) {
        var inputValue = cartItem[i].querySelector("input")
        inputValue.addEventListener("change", function () {
            carttotal()
        })
    }
}


// ---------------------cart----------------------
adresscartbtn.addEventListener("click", function () {
    document.querySelector('.adress-cart').style.display = "flex"
})
adressclosecart.addEventListener("click", function () {
    document.querySelector('.adress-cart').style.display = "none"
})
// ---------------------thanh toán----------------------

// ---------------------history----------------------

adresshistorybtn.addEventListener("click", function () {
    document.querySelector('.adress-history').style.display = "flex"
})
adressclosehistory.addEventListener("click", function () {
    document.querySelector('.adress-history').style.display = "none"
})
// ---------------------help----------------------

adresshelpbtn.addEventListener("click", function () {
    document.querySelector('.adress-help').style.display = "flex"
})
adressclosehelp.addEventListener("click", function () {
    document.querySelector('.adress-help').style.display = "none"
})

// ---------------------thongbao----------------------

adressthongbaobtn.addEventListener("click", function () {
    document.querySelector('.adress-thongbao').style.display = "flex"
})
adressclosethongbao.addEventListener("click", function () {
    document.querySelector('.adress-thongbao').style.display = "none"
})

// _----------------regisrt-------------------

adressregisrtbtn.addEventListener("click", function () {
    document.querySelector('.adress-regisrt').style.display = "flex"
})
adresscloseregisrt.addEventListener("click", function () {
    document.querySelector('.adress-regisrt').style.display = "none"
})

// ---------------login----------

adressloginbtn.addEventListener("click", function () {
    document.querySelector('.adress-login').style.display = "flex"
})
adresscloselogin.addEventListener("click", function () {
    document.querySelector('.adress-login').style.display = "none"
})

// ---------------------address--------------------

adressbtn.addEventListener("click", function () {
    document.querySelector('.adress-form').style.display = "flex"
})
adressclose.addEventListener("click", function () {
    document.querySelector('.adress-form').style.display = "none"
})

// $(document).ready(function(){
//     $('#eye').click(function(){
//         $(this).toggleClass('open');
//         $(this).children('i').toggleClass('fa-eye-slash fa-eye');
//         if($(this).hasClass('open')){
//             $(this).prev().attr('type', 'text');
//         }else{
//             $(this).prev().attr('type', 'password');
//         }
//     });
// });
