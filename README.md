[![Docker Image CI](https://github.com/wellingtonpoll/Github.Webhook/actions/workflows/docker-image.yml/badge.svg)](https://github.com/wellingtonpoll/Github.Webhook/actions/workflows/docker-image.yml)

## About

<!-- A description of the package and where one can find more documentation -->
A web hook to receive github events.

# run on docker
```sh
docker build -t github-webhook .
docker run -d -p 80:80 github-webhook
```

# deploy heroku
```sh
heroku container:push web -a github-webhook
heroku container:release web -a github-webhook
```

## Give a Star! :star:
If you liked the project or if it helped you in any way, please consider leaving a like.