#!/bin/bash

git checkout master
git pull
git branch -D cjavilla-codegen-integration4
git checkout -b cjavilla-codegen-integration4
grep -rl '///' src/Stripe.net/{Entities,Services}* | xargs sed -i '' -e '/\/\/\/ .*/d'
git checkout -- src/Stripe.net/{Entities,Services}/_*
git add -A
git commit -m 'remove comments'
git branch -D cjavilla-codegen-wip-branch
git checkout -b cjavilla-codegen-wip-branch
