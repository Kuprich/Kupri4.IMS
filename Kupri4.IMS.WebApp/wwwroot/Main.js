
function fadeOut(el) {

	var opacity = 1;

	var timer = setInterval(function () {

		if (opacity <= 0.1) {

			clearInterval(timer);
			document.querySelector(el).style.display = "none";

		}

		document.querySelector(el).style.opacity = opacity;

		opacity -= opacity * 0.1;

	}, 5);
}

function fadeOutWithDelay(el, ms) {
	setTimeout(() => fadeOut(el), ms);
}


function fadeIn(el) {

	var opacity = 0.01;

	document.querySelector(el).style.display = "block";

	var timer = setInterval(function () {

		if (opacity >= 1) {

			clearInterval(timer);

		}

		document.querySelector(el).style.opacity = opacity;

		opacity += opacity * 0.7;

	}, 5);

}



