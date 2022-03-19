module.exports = ({ env }) => ({
  auth: {
    secret: env('ADMIN_JWT_SECRET', '5ae3a664afdc0f87489d4cfecdf0016d'),
  },
});
