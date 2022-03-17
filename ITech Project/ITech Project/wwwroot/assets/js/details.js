
let caTitles = document.querySelectorAll("#ca-title span")
let caBody = document.querySelectorAll("#ca-body div")

for (let index in caTitles) {
    caTitles[0].style.backgroundColor = "var(--third-color)"
    caTitles[index].onclick = () => {

        for (let i = 0; i < caBody.length; i++) {
            caBody[i].setAttribute("hidden", "")
            caTitles[i].style.backgroundColor = ""
            caBody[index].removeAttribute("hidden")
            caTitles[index].style.backgroundColor = "var(--third-color)"
        }

    }
}

let cReviews = document.querySelectorAll(".Customers-reviews i")
let reviewValue = document.querySelector(".review-value")
let submitBtn = document.querySelector(".Customers-reviews button")
let submitBtnLink = document.querySelector(".submitBtnLink a")
let CurrnetPagelink = window.location.href

console.log("ahmed")
console.log(submitBtnLink)
for (let i = 0; i < cReviews.length; i++) {

    // click event on icons to change href
    cReviews[i].addEventListener("click", () => {
        submitBtn.removeAttribute("disabled")
        ClickChk: switch (i) {
            case 0:
                if (submitBtnLink !== null)
                    submitBtnLink.setAttribute("href", CurrnetPagelink.replace("GetById", "AddReview") + "?Rank=1")
                reviewValue.textContent = "very bad"
                break ClickChk;

            case 1:
                if (submitBtnLink !== null)
                    submitBtnLink.setAttribute("href", CurrnetPagelink.replace("GetById", "AddReview") + "?Rank=2")
                reviewValue.textContent = "bad"
                break ClickChk;

            case 2:
                if (submitBtnLink !== null)
                    submitBtnLink.setAttribute("href", CurrnetPagelink.replace("GetById", "AddReview") + "?Rank=3")
                reviewValue.textContent = "Good"
                break ClickChk;

            case 3:
                if (submitBtnLink !== null)
                    submitBtnLink.setAttribute("href", CurrnetPagelink.replace("GetById", "AddReview") + "?Rank=4")
                reviewValue.textContent = "Very good"
                break ClickChk;

            case 4:
                if (submitBtnLink !== null)
                    submitBtnLink.setAttribute("href", CurrnetPagelink.replace("GetById", "AddReview") + "?Rank=5")
                reviewValue.textContent = "Excellent"
                break ClickChk;
        }
    })

    // change star class on click
    cReviews[i].addEventListener("click", () => {
        for (let c = 0; c < 5; c++) 
            cReviews[c].classList.replace("bxs-star", "bx-star");
        for (let j = 0; j <= i; j++)
            cReviews[j].classList.replace("bx-star", "bxs-star");
    })
}