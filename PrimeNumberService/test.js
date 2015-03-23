asyncTest('Ajax tests', function(){
	expect(1); // we have one async test to run
	
	var xhr = $.ajax({
		type: 'POST',
		url: 	'http://localhost/PrimeNumberService/PrimeService.svc/ShowThousandPrime'
	})
	.always(function(data, status){		
		var answer = data.ShowThousandPrimeResult;
		notEqual(answer, '2, 3, 5, 7, 11, 13, 17, 19, 23, 29', 'Wrong total number of primes found');
		equal(answer, '2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31',  'Right total number of primes found');
		QUnit.start(); // we have our answer for this assertion, continue testing other assertions
	});

});